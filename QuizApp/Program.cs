class QuizProgram
{
    static void Main()
    {
        //  Create Questions
        string[] questions =
        {
            "Which car brand is known for its luxury sports model called'911'? ",
            "What is the popular traction cotrol system that helps prevent wheel skidding during driving called?",
            "Which company is the world's largest producer of elecric cars?"
        };

        // Create Answers
        string[] answers =
        {
            "A. BMW \nB. Porsche \nC. Ferrari",
            "A. TCS \nB. ABS \nC. ESP",
            "A. Mercedes \nB. Audi \nC. Tesla"
        };

        int[] correctAnswers = { 1, 0, 2 };
        int playerScore = 0;

        Console.WriteLine("Welcome to the best Car Quiz App ever :)");
        for (int i = 0; i < questions.Length; i++) 
        {
            Console.WriteLine("Question " + (i + 1));
            Console.WriteLine(questions[i]);
            Console.WriteLine(answers[i]);
            Console.Write("Please enter your answer ('A' ,'B' ,or 'C'): ");
            string playerAnswer = Console.ReadLine();

            // Validating Answers
            if(string.Equals(playerAnswer, "A", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] ==0)
            {
                playerScore++;
            }
            else if(string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 1)
            {
                playerScore++;
            }
            else if(string.Equals(playerAnswer, "C", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 2)
            {
                playerScore++;
            }

          

        }
        // Print score out to user
        Console.WriteLine("Quiz Completed!");
        Console.WriteLine("Your score is: " + playerScore + "/" + questions.Length);
    }
}