using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;
        public Form1()
        {
            InitializeComponent();
            InitializeQuestions();
            ShowQuestion();
        }
        private void InitializeQuestions()
        {
            // Tạo danh sách các câu hỏi
            questions = new List<Question>
            {
                new Question("Câu hỏi 1: Bạn học môn kĩ năng mềm nào chưa?", new List<string> { "Chưa", "Đã học", "Học hết rồi" }, 0),
                new Question("Câu hỏi 2: Nguyễn Huệ và Quang Trung có mối quan hệ gì?", new List<string> { "Anh em", "Cha con", "Một người" }, 1),
                new Question("Câu hỏi 3: Trời đang mưa hay nắng?", new List<string> { "Mưa", "Nắng", "Mưa nắng" }, 2),
            };

            // Khởi tạo chỉ số câu hỏi hiện tại
            currentQuestionIndex = 0;
        }
        private void ShowQuestion()
        {
            // Hiển thị câu hỏi và các đáp án
            Question currentQuestion = questions[currentQuestionIndex];
            lblQuestion.Text = currentQuestion.Content;

            radioBtnOption1.Text = currentQuestion.Options[0];
            radioBtnOption2.Text = currentQuestion.Options[1];
            radioBtnOption3.Text = currentQuestion.Options[2];

            // Xóa chọn đáp án
            radioBtnOption1.Checked = false;
            radioBtnOption2.Checked = false;
            radioBtnOption3.Checked = false;
        }
            private void button1_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                ShowQuestion();
            }
            else
            {
                MessageBox.Show("Kết thúc đề thi!");
                this.Close(); // Đóng ứng dụng sau khi kết thúc
            }
        }
        public class Question
        {
            public string Content { get; }
            public List<string> Options { get; }
            public int CorrectOptionIndex { get; }

            public Question(string content, List<string> options, int correctOptionIndex)
            {
                Content = content;
                Options = options;
                CorrectOptionIndex = correctOptionIndex;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
