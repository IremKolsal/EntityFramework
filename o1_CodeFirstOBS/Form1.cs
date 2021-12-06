using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace o1_CodeFirstOBS
{
    public partial class Form1 : Form
    {
        /*
         Bir üniversite için öğrenci bilgi sistemi uygulaması yaptığınızı düşünün.
        - Tablolar : 
        1. Student(id, name, surname, tckn, studentnumber, TeacherId, DepartmentId)
        2. Student Detail(Id,Adress, Phone, Gender)
        3. Teacher(Id, Name, Surname, Tckn, Branch, title, List<Student>)
        4.Lesson(Id, Name, Code)
        5.Faculty(Id, Name, List<Department>)
        6.Department(Id, Name, FacultyId, List<Student>)
      + 7.StudentLesson (StudentId, LessonId)
      + 8.TeacherLesson(TeacherId, LessonId)
      + 9.LessonDepartment(lessonId, DepartmentId)

        -İlişkiler:
        1. Student - Student Detail: 1-1
        2. Student - Teacher: 1-n (DanışmanEğitmen)*
        3. Student - Lesson : n-n (StudentLesson ara tablosu yapılacak)
        4. Teacher - Lesson : n-n
        5. Faculty - Department : 1-n*
        6. Faculty - Lesson : n-n (FacultyLesson)
        7. Student - Department : 1-n*

         */
        public Form1()
        {
            InitializeComponent();
        }
    }
}
