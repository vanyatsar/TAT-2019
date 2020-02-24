using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject.PageObjectLibrary
{
    class TestInvoker
    {
        private List<string> ButtonsNames { get; set; }
        CalculatorMainPage Calculator { get; set; }

        /// <summary>
        /// Initialize test invoker
        /// </summary>
        /// <param name="calculator">calculator page</param>
        public TestInvoker(CalculatorMainPage calculator)
        {
            Calculator = calculator;
            ButtonsNames = new List<string>();
        }

        /// <summary>
        /// Return calculation result from result web element
        /// </summary>
        /// <param name="buttonSequence">expression to evaluate</param>
        /// <returns>calculation result</returns>
        public string GetResult(string buttonSequence)
        {
            //ButtonsNames = null;
            ButtonsNames = buttonSequence.Split(new char[] { ' ' }).ToList();

            foreach (var buttonName in ButtonsNames)
            {
                Calculator.WebElements[buttonName].Click();
            }
            return Calculator.ResultWebElement.Text;
        }
    }
}
