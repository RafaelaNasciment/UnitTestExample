using Domain;

namespace UnitTestExample
{
    public class TaskTests
    {
        [Fact]
        public void CreateTasksWithSucess()
        {
            //Arrange
            var title = "Lunch";
            var description = "Meet my friend for lunch";
            var expirationDate = DateTime.Now;
            var priority = 1;
            var labels = new[] { "Lunch", "Task" };

            //Act
            var task = new Tarefa(
                title: title,
                description: description,
                expirationDate: expirationDate,
                priority: priority,
                labels: labels);

            //Assert
            Assert.Equal(task.Title, title);
            Assert.Equal(task.Description, description);
            Assert.Equal(task.ExpirationDate, expirationDate);
            Assert.Equal(task.Priority, priority);
            Assert.Equal(task.Labels, labels);

        }
    }
}