namespace NUnitTestProject.PageObjectLibrary
{
    class TestInvoker
    {
        private string[] ButtonsNames { get; set; } 
        CalculatorMainPage Calculator { get; set; }

        public TestInvoker(CalculatorMainPage calculator)
        {
            Calculator = calculator;
        }
        
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
