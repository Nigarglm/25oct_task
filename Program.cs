namespace _25oct_task
{
    internal class Program
    {
        static List<Quiz> quizzes = new List<Quiz>();
        static void Main(string[] args)
        {
            {

                Console.WriteLine("1. Create new quiz");
                Console.WriteLine("2. Solve a quiz");
                Console.WriteLine("3. Show quizzes");
                Console.WriteLine("0. Quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateNewQuiz();
                        break;
                    case "2":
                        SolveQuiz();
                        break;
                    case "3":
                        ShowQuizzes();
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }

                 static void CreateNewQuiz()
                {
                    Console.WriteLine("Enter quiz name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("How many questions do you want to add?");
                    int numberOfQuestions = Convert.ToInt32(Console.ReadLine());

                    List<Question> questions = new List<Question>();

                    for (int i = 0; i < numberOfQuestions; i++)
                    {
                        Question question = new Question();

                        Console.WriteLine($"Enter questions: {i + 1}:");
                        question.Text = Console.ReadLine();

                        Console.WriteLine("Enter variants:");
                        int numberOfVariants = Convert.ToInt32(Console.ReadLine());
                        question.Variants = new List<string>();

                        for (int j = 0; j < numberOfVariants; j++)
                        {
                            Console.WriteLine($"Enter variants count {j + 1}:");
                            question.Variants.Add(Console.ReadLine());
                        }

                        Console.WriteLine("Enter correct variant number:");
                        question.CorrectVariant = Convert.ToInt32(Console.ReadLine());

                        questions.Add(question);
                    }

                    
                    Quiz quiz = new Quiz(name, questions);
                    quizzes.Add(quiz);

                    Console.WriteLine("Quiz created successfully.");
                }


                static void ShowQuizzes()
                {
                    foreach (var quiz in quizzes)
                    {
                        Console.WriteLine($"Id: {quiz.Id}, Name: {quiz.Name}");
                    }
                }


                static void SolveQuiz()
                {
                    Console.WriteLine("==============================");
                    Console.WriteLine("Enter the Id:");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Quiz selectedQuiz = quizzes.Find(q => q.Id == id);

                    if (selectedQuiz == null)
                    {
                        Console.WriteLine("Quiz not found!");
                        return;
                    }

                    int result = 0;

                    foreach (var question in selectedQuiz.Questions)
                    {
                        Console.WriteLine(question.Text);

                        for (int i = 0; i < question.Variants.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {question.Variants[i]}");
                        }

                        Console.WriteLine("Your answer:");
                        int answer = Convert.ToInt32(Console.ReadLine());

                        if (answer == question.CorrectVariant)
                        {
                            result++;
                        }
                    }
                }

            }
        }

    }
}