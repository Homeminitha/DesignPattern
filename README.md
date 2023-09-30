# DesignPattern

# Simple Factory Design Pattern:
  Let’s say in the future, CalculatorFactory has to make a new type of Calculator called **FinancialCalculator**. To adopt this new requirement, we have to change the **CreateCalculator** method and add one more switch case for the FinancialCalculator type. If again new kind of Calculator is introduced, then again one more case needs to be added. This will be a violation of Open Close Principle of SOLID principles. We can overcome this violation issue with the help of the Factory Method Pattern.
