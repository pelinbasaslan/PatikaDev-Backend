namespace Pratik1_DI
{
    public class Classroom
    {
        private readonly ITeacher _teacher;
        public Classroom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public void GetTeacherInfo()
        {
            _teacher.GetInfo();
        }

    }
}