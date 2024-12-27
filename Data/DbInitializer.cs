using OnlineSchool.Models;

namespace OnlineSchool.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Check if there are any courses
            if (context.Courses.Any())
            {
                return;   // DB has been seeded
            }

            var courses = new Course[]
            {
                new Course
                {
                    Title = "Веб-разработка с нуля",
                    Description = "Научитесь создавать современные веб-сайты с использованием HTML, CSS и JavaScript",
                    Price = 999,
                    ImageUrl = "https://images.unsplash.com/photo-1498050108023-c5249f4df085",
                    Duration = "3 месяца",
                    Level = "Начинающий",
                    CreatedAt = DateTime.Now
                },
                new Course
                {
                    Title = "Python для начинающих",
                    Description = "Изучите основы программирования на Python и создайте свои первые приложения",
                    Price = 799,
                    ImageUrl = "https://images.unsplash.com/photo-1526379095098-d400fd0bf935",
                    Duration = "2 месяца",
                    Level = "Начинающий",
                    CreatedAt = DateTime.Now
                },
                new Course
                {
                    Title = "Дизайн интерфейсов",
                    Description = "Научитесь создавать красивые и удобные интерфейсы для веб-сайтов и приложений",
                    Price = 1299,
                    ImageUrl = "https://images.unsplash.com/photo-1561070791-2526d30994b5",
                    Duration = "4 месяца",
                    Level = "Средний",
                    CreatedAt = DateTime.Now
                },
                new Course
                {
                    Title = "Java программирование",
                    Description = "Изучите Java и создавайте мощные приложения для различных платформ",
                    Price = 1499,
                    ImageUrl = "https://images.unsplash.com/photo-1517694712202-14dd9538aa97",
                    Duration = "6 месяцев",
                    Level = "Средний",
                    CreatedAt = DateTime.Now
                },
                new Course
                {
                    Title = "Мобильная разработка",
                    Description = "Научитесь создавать мобильные приложения для iOS и Android",
                    Price = 1699,
                    ImageUrl = "https://images.unsplash.com/photo-1512941937669-90a1b58e7e9c",
                    Duration = "5 месяцев",
                    Level = "Продвинутый",
                    CreatedAt = DateTime.Now
                },
                new Course
                {
                    Title = "Data Science и Machine Learning",
                    Description = "Изучите анализ данных и машинное обучение на практических примерах",
                    Price = 1999,
                    ImageUrl = "https://images.unsplash.com/photo-1509228627152-72ae9ae6848d",
                    Duration = "6 месяцев",
                    Level = "Продвинутый",
                    CreatedAt = DateTime.Now
                }
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            // Add sample lessons for the first course
            var lessons = new Lesson[]
            {
                new Lesson
                {
                    Title = "Введение в HTML",
                    Description = "Изучим основы HTML и создадим первую веб-страницу",
                    CourseId = courses[0].Id,
                    OrderNumber = 1,
                    VideoUrl = "https://www.youtube.com/embed/sample1"
                },
                new Lesson
                {
                    Title = "Основы CSS",
                    Description = "Научимся стилизовать веб-страницы с помощью CSS",
                    CourseId = courses[0].Id,
                    OrderNumber = 2,
                    VideoUrl = "https://www.youtube.com/embed/sample2"
                },
                new Lesson
                {
                    Title = "JavaScript основы",
                    Description = "Изучим основы программирования на JavaScript",
                    CourseId = courses[0].Id,
                    OrderNumber = 3,
                    VideoUrl = "https://www.youtube.com/embed/sample3"
                }
            };

            context.Lessons.AddRange(lessons);
            context.SaveChanges();
        }
    }
}
