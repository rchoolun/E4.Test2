using System;

namespace E4.Test2
{
    public static class Calculator
    {
        /// <summary>
        /// Add numbers input from USER
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static string Add(string numbers)
        {
            try
            {
                //Check for empty input
                if (string.IsNullOrEmpty(numbers))
                {
                    return "0";
                }

                //Check if the input is a number
                if (int.TryParse(numbers, out int number))
                {
                    return number.ToString();
                }

                var delimeter = ',';

                //Check if the input start the "//"
                if (numbers.StartsWith("//"))
                {
                    delimeter = numbers[2];
                    numbers = numbers.Remove(0, 3);
                }

                //Check if the input contains "\n"
                if (numbers.IndexOf(@"\n") >= 0)
                {
                    numbers = numbers.Replace(@"\n", delimeter.ToString());
                }

                //Check if delimeter present in input
                if (numbers.IndexOf(delimeter) >= 0)
                {
                    //Split the input
                    var splitNum = numbers.Split(delimeter);

                    var sum = 0;
                    string negativeNumber = string.Empty;

                    for (int i = 0; i < splitNum.Length; i++)
                    {
                        if (int.TryParse(splitNum[i], out int numberFromArray))
                        {
                            if (numberFromArray < 0)
                            {
                                //Record negative numbers
                                negativeNumber += "," + numberFromArray.ToString();
                            }
                            else
                            {
                                sum += numberFromArray;
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(negativeNumber))
                    {
                        return negativeNumber.TrimStart(',');
                    }

                    return sum.ToString();
                }

                return "No Operation";
            }
            catch(Exception ex)
            {
                return String.Concat("ERROR: ", ex.Message);
            }   
        }
    }
}
