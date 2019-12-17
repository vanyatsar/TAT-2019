namespace NUnitTestProject.PageObjectLibrary
{
    class TestInvoker
    {
        private string[] ButtonsNames { get; set; } 
        CalculatorMainPage Calculator { get; set; }

        /// <summary>
        /// Initialize test invoker
        /// </summary>
        /// <param name="calculator">calculator page</param>
        public TestInvoker(CalculatorMainPage calculator)
        {
            Calculator = calculator;
        }

        /// <summary>
        /// Return calculation result from result web element
        /// </summary>
        /// <param name="buttonSequence">expression to evaluate</param>
        /// <returns>calculation result</returns>
        public string GetResult(string buttonSequence)
        {
            ButtonsNames = null;
            ButtonsNames = buttonSequence.Split(new char[] { ' ' });

            foreach (var buttonName in ButtonsNames)
            {
                Calculator.WebElements[buttonName].Click();
            }
            return Calculator.ResultWebElement.Text;
        }
    }
}
