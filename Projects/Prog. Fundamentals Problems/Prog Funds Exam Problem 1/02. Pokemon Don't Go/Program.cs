using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                int removedElementsSum = 0;

                while (true)
                {

                    if (numbers.Count > 0)
                    {
                        int index = int.Parse(Console.ReadLine());

                        if (index >= 0 && index < numbers.Count)
                        {
                            int currentElement = numbers[index];

                            removedElementsSum += currentElement;

                            numbers.RemoveAt(index);

                            if (numbers.Count > 0)
                            {
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] <= currentElement)
                                    {
                                        numbers[i] += currentElement;
                                    }
                                    else if (numbers[i] > currentElement)
                                    {
                                        numbers[i] -= currentElement;
                                    }
                                }
                            }

                            else if (numbers.Count == 0)
                            {
                                break;
                            }

                        }

                        else if ((index < 0 || index > numbers.Count-1) && numbers.Count > 0)
                        {
                            //numbers.RemoveAt(index);
                            if (index < 0)
                            {
                                if (numbers.Count > 0)
                                {
                                    int copyOfLastElement = numbers[numbers.Count - 1];

                                    int copyOfRemovedElement = numbers[0];//removed element

                                    removedElementsSum += numbers[0];

                                    numbers.RemoveAt(0);
                                    numbers.Insert(0, copyOfLastElement);

                                    if (numbers.Count > 0)
                                    {
                                        for (int i = 0; i < numbers.Count; i++)
                                        {

                                            if (numbers[i] <= copyOfRemovedElement)
                                            {
                                                numbers[i] += copyOfRemovedElement;
                                            }
                                            else if (numbers[i] > copyOfRemovedElement)
                                            {
                                                numbers[i] -= copyOfRemovedElement;
                                            }
                                        }
                                    }
                                }

                                else if (numbers.Count == 0)
                                {
                                    break;
                                }
                            }

                            else if (index > numbers.Count-1)
                            {
                                if (numbers.Count > 0)
                                {
                                    int copyLastElement = numbers[numbers.Count - 1];//the removed element

                                    removedElementsSum += copyLastElement;

                                    numbers.Insert(numbers.Count - 1, numbers[0]);//puts first at last place
                                    numbers.RemoveAt(numbers.Count - 2);//removes the beforelast element which is the last at hte case.


                                    if (numbers.Count > 0)
                                    {
                                        for (int i = 0; i < numbers.Count; i++)
                                        {
                                            if (numbers[i] <= copyLastElement)
                                            {
                                                numbers[i] += copyLastElement;
                                            }
                                            else if (numbers[i] > copyLastElement)
                                            {
                                                numbers[i] -= copyLastElement;
                                            }
                                        }
                                    }
                                }

                                else if (numbers.Count == 0)
                                {
                                    break;
                                }
                            }

                        }
                    }

                    else if (numbers.Count == 0)
                    {
                        break;
                    }
                }

                Console.WriteLine(removedElementsSum); 
            }
        }
    }
}
