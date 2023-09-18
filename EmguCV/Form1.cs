using DirectShowLib;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Dnn;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguCV
{
    public partial class Form1 : Form
    {
        private string path;
        Mat img;
        private VideoCapture videoCapture = null;
        private DsDevice[] webCams = null;
        private int selectedCameraId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void PoseEstimationBody_25()
        {
            try
            {
                // for openopse
                int inWidth = 368;
                int inHeight = 368;
                float threshold = 0.1f;
                int nPoints = 25;

                var BODY_PARTS = new Dictionary<string, int>()
                {
                    { "Nose", 0 },
                    { "Neck", 1 },
                    { "RShoulder", 2 },
                    { "RElbow", 3 },
                    { "RWrist", 4 },
                    {"LShoulder",5},
                    { "LElbow", 6 },
                    { "LWrist", 7 },
                    { "MidHip", 8 },
                    { "RHip", 9 },
                    { "RKnee", 10 },
                    {"RAnkle",11},
                    { "LHip", 12 },
                    { "LKnee", 13 },
                    { "LAnkle", 14 },
                    { "REye", 15 },
                    { "LEye", 16 },
                    {"REar",17},
                    { "LEar", 18 },
                    { "LBigToe", 19 },
                    { "LSmallToe", 20 },
                    { "LHeel", 21 },
                    { "RBigToe", 22 },
                    {"RSmallToe",23},
                    { "RHeel", 24 },
                    { "Background", 25 }
                };

                int[,] point_pairs = new int[,]{
                            {1, 0}, {1, 2}, {1, 5},
                            {2, 3}, {3, 4}, {5, 6},
                            {6, 7}, {0, 15}, {15, 17},
                            {0, 16}, {16, 18}, {1, 8},
                            {8, 9}, {9, 10}, {10, 11},
                            {11, 22}, {22, 23}, {11, 24},
                            {8, 12}, {12, 13}, {13, 14},
                            {14, 19}, {19, 20}, {14, 21}};

                string currentDir = Directory.GetCurrentDirectory();

                img = new Mat(path);

                // Load the caffe Model
                string prototxt = @".\..\..\..\openCV\models\pose_deploy.prototxt";
                string modelPath = @".\..\..\..\openCV\models\pose_iter_584000.caffemodel";

                var net = DnnInvoke.ReadNetFromCaffe(prototxt, modelPath);

                var blob = DnnInvoke.BlobFromImage(img, 1.0 / 255.0, new Size(inWidth, inHeight), new MCvScalar(0, 0, 0));
                net.SetInput(blob);
                net.SetPreferableBackend(Emgu.CV.Dnn.Backend.OpenCV);

                var output = net.Forward();

                var H = output.SizeOfDimension[2];
                var W = output.SizeOfDimension[3];
                var HeatMap = output.GetData();

                var points = new List<Point>();

                for (int i = 0; i < nPoints; i++)
                {
                    Matrix<float> matrix = new Matrix<float>(H, W);
                    for (int row = 0; row < H; row++)
                    {
                        for (int col = 0; col < W; col++)
                        {
                            matrix[row, col] = (float)HeatMap.GetValue(0, i, row, col);
                        }
                    }

                    double minVal = 0, maxVal = 0;
                    Point minLoc = default, maxLoc = default;

                    CvInvoke.MinMaxLoc(matrix, ref minVal, ref maxVal, ref minLoc, ref maxLoc);

                    var x = (img.Width * maxLoc.X) / W;
                    var y = (img.Height * maxLoc.Y) / H;

                    if (maxVal > threshold)
                    {
                        points.Add(new Point(x, y));
                    }
                    else
                    {
                        points.Add(Point.Empty);
                    }
                }

                // display points on image
                for (int i = 0; i < points.Count; i++)
                {
                    var p = points[i];
                    if (p != Point.Empty)
                    {
                        CvInvoke.Circle(img, p, 5, new MCvScalar(0, 255, 0), -1);
                        CvInvoke.PutText(img, i.ToString(), p, FontFace.HersheySimplex, 0.8, new MCvScalar(0, 0, 255), 1, LineType.AntiAlias);
                    }
                }

                // draw skeleton

                for (int i = 0; i < point_pairs.GetLongLength(0); i++)
                {
                    var startIndex = point_pairs[i, 0];
                    var endIndex = point_pairs[i, 1];

                    if (points.Contains(points[startIndex]) && points.Contains(points[endIndex]) &&
                        points[startIndex].X != 0 && points[startIndex].Y != 0 &&
                        points[endIndex].X != 0 && points[endIndex].Y != 0)
                    {
                        CvInvoke.Line(img, points[startIndex], points[endIndex], new MCvScalar(255, 255, 0), 5);
                    }
                }

                //img.Save($"Sceleton{DateTime.Now.Second}.jpg");
                picShow.Image = img.ToImage<Bgr, Byte>().ToBitmap<Bgr, Byte>();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChooseClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the title of the dialog
            openFileDialog.Title = "Open File";
            // Define the file filters
            openFileDialog.Filter = "*.jpg|*.jpg|.png|*.png|All Files|*.*";

            // Allow multiple file selection (optional)
            openFileDialog.Multiselect = false;

            // Show the dialog and get the result
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // The user selected a file
                path = openFileDialog.FileName;
            }
            else
            {
                return;
            }

            Image originalImage = Image.FromFile(path);

            picChoose.Image = originalImage;
        }

        private void FindPoseClick(object sender, EventArgs e)
        {
            PoseEstimationBody_25();
        }

        private void SaveRecognizedPosePhoto(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set the title of the dialog
            saveFileDialog.Title = "Save File";
            // Define the file filters
            saveFileDialog.Filter = "*.jpg|*.jpg|.png|*.png|All Files|*.*";


            string savePath;

            // Show the dialog and get the result
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // The user selected a file
                savePath = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            img.Save(savePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webCams = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);

            for (int i = 0; i < webCams.Length; i++)
            {
                cameraCMB.Items.Add(webCams[i].Name);
            }
        }

        private void cameraCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCameraId = cameraCMB.SelectedIndex;
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (webCams.Length == 0)
                {
                    throw new Exception("Нет достпуных камер!");
                }
                else if (cameraCMB.SelectedItem == null)
                {
                    throw new Exception("Необъодимо выбрать камеру!");
                }
                else if (videoCapture != null)
                {
                    videoCapture.Start();
                }
                else
                {
                    videoCapture = new VideoCapture(selectedCameraId);
                    videoCapture.ImageGrabbed += VideoFromWebCamToPictureBox;

                    videoCapture.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VideoFromWebCamToPictureBox(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();

                videoCapture.Retrieve(m);
                
                videoBox.Image = m.ToImage<Bgr, Byte>().Flip(FlipType.Horizontal).ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoCapture != null)
                {
                    videoCapture.Pause();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoCapture != null)
                {
                    videoCapture.Pause();

                    videoCapture.Dispose();

                    videoCapture = null;

                    videoBox.Image.Dispose();

                    videoBox.Image=null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
