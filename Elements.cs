using OpenQA.Selenium;
namespace WebTest
{
    public class Elements
    {
        //origin
        public IWebElement origin= Methods.driver.FindElement(By.Name("origin"));
        //destination
        public IWebElement destination= Methods.driver.FindElement(By.Name("destination"));
        //departure time
        public IWebElement dtime= Methods.driver.FindElement(By.Name("d"));
        //arrival time
        public IWebElement atime= Methods.driver.FindElement(By.Name("a"));
       //Passengers
        public IWebElement passengers = Methods.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/form/div/div/div[3]/span/div[2]"));
       //adult
        public IWebElement adult= Methods.driver.FindElement(By.Name("adult"));
       //child
        public IWebElement child= Methods.driver.FindElement(By.Name("child"));
       //infant
        public IWebElement infant= Methods.driver.FindElement(By.Name("infant"));
       //Economy
       public IWebElement Economy = Methods.driver.FindElement(By.XPath("//*[@id="el-popover-9938"]/div[1]/div[2]/div/div/div[1]"));
      //Premium
       public IWebElement Premium = Methods.driver.FindElement(By.XPath("//*[@id="el-popover-9938"]/div[1]/div[2]/div/div/div[2]"));
     //Business
       public IWebElement Business = Methods.driver.FindElement(By.XPath("//*[@id="el-popover-9938"]/div[1]/div[2]/div/div/div[3]"));
     //first
       public IWebElement first = Methods.driver.FindElement(By.XPath("//*[@id="el-popover-9938"]/div[1]/div[2]/div/div/div[4]"));
     //search
       public IWebElement search = Methods.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/form/div/div/div[4]/button"));
     //firstname
       public IWebElement firstname = Methods.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div[3]/div/form/div/div[1]/div[1]/div/div[2]/div/div/div[1]/input"));
      //lastname
       public IWebElement lastname = Methods.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div[3]/div/form/div/div[1]/div[2]/div/div[2]/div/div/div[1]/input"));   
       //email
       public IWebElement email = Methods.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div[3]/div/form/div/div[2]/div/div/div[2]/div/div/div[1]/input"));   
      //Passowrd
      public IWebElement password = Methods.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div[3]/div/form/div/div[3]/div/div/div[2]/div/div/div[1]/div/input"));   
      //creat account
      public IWebElement submit = Methods.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div[3]/div/form/div/div[4]/div/button"));   
     //firstname in contact
      public IWebElement C_firstname = Methods.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/div/div[3]/div[1]/div/form/div/div[1]/div[1]/div/div[1]/div/input")); 
    //email in contact
      public IWebElement C_email = Methods.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/div/div[3]/div[1]/div/form/div/div[1]/div[2]/div/div[1]/div/input"));   
       //category
      public IWebElement category = Methods.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/div/div[3]/div[1]/div/form/div/div[1]/div[3]/div/div/div/div[1]/input"));    
     //Message
      public IWebElement Message = Methods.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/div/div[3]/div[1]/div/form/div/div[2]/div/div/div[1]/div/textarea"));    

     //Send
      public IWebElement send = Methods.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/div/div[3]/div[1]/div/form/div/div[3]/button"));    

      //thank you message
      public IWebElement thanks = Methods.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[3]/div/div[3]/div[1]/div/form/div[1]/div[4]/div/h3"));   


     }
}
