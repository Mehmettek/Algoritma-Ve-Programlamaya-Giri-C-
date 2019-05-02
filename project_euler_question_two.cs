int f1 = 1, f2 = 1, answer = 0, sum = 0;

            while (sum < 400000)
            {
                if ((answer % 2) == 0)
                {
                    sum += answer;
                }
                answer = f1 + f2;

                f2 = f1;
                f1 = answer;

            }
            Console.Write("Answer: " + sum);
            Console.Read();