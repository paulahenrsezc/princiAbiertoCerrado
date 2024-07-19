using System;

namespace princiAbiertoCerrado
{
    public class HybridCourse : Course
    {
        private OnlineCourse onlineCourse;
        private OnsiteCourse onsiteCourse;

        public HybridCourse(OnlineCourse onlineCourse, OnsiteCourse onsiteCourse)
        {
            this.onlineCourse = onlineCourse;
            this.onsiteCourse = onsiteCourse;
        }

        public override void Subscribe(Student std)
        {
            onlineCourse.Subscribe(std);
            onsiteCourse.Subscribe(std);
        }
    }

}
