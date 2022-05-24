# HKI-Framework
 
This is a test automation framework which allows to automate web and mobile testing. It is built in an .NET environment and allows for web & mobile test automation. Additionally sequential, parallel and cross-platform testing can be executed. 

The HKI Framework consists of 9 main components where the core structure is built around. 
These components are built in modules and with respect to the SOLID principles. The 
components and their core functionality will be listed here:

**Base**: Consists of the BasePage where the drivers all pages depend on are injected.

**Builders**: This component is responsible for building and closing drivers.

**Enums**: A collection of different enumerations.

**Extensions**: A collection of methods that facilitate the tester when writing scripts. This is where 
Selenium and Appium are called upon in order to push back the dependency in the actual POM 
and test scripts.

**Helpers**: This component is the driving force of the framework. All configurations (web-mobiledrivers, logger, TestRail and environment) are handled here as well as initializing drivers.

**Models**: A collection of properties initialized in the Helpers and use across the entire solution.
TestRail (or other test management tool): Contains the setup and configuration of the test 
management tool with which will be connected. 

**Utilities**: Collection of methods which facilitate the core process, such as the event loggers. 

**WebElementModels**: This component is responsible for finding an initializing web- and mobile 
elements.

### User Manual

Here we will provide a flow that should be followed when automating test

1. **Write a good test case**<br>
Before automating any test, it is important that we know what we want to test. This includes defining clear chronological steps and what their expected results are. Equally important are the preconditions, containing all needed preparatory steps that are important for executing the test case.
 
2. **Install the HKI NuGet-package**<br>
As previously stated, this can be achieved by executing the following command in the Package Manager console.
"Install-Package HKI_Automation_Framework -Version 1.0.0"
 
3. **Configure global variables**<br>
As stated in section "Installation", we can configure our global variables in the appSettings file. An example of global
settings for testing B-Tube:

 
4. **Define global elements and methods in BasePage**<br>
When testing the same application, there are bound to be repeating actions across most or all of the pages/screens. These actions or properties can be defined in the BasePage. First create a folder called Pages for web and Screens for mobile and create a class called BasePage. An example of methods we defined in our BasePage when testing B-Tube:


 
5. **Define global actions in BaseTest**<br>
Recurring actions for each test case in a suite can be defined in the base test. Create a folder named "Tests" containing a seperate folder for mobile and web tests. There we can create the BaseTest and insert tests therein.

 
 
6. **Page Object Model**<br>
Create the page objects in the "Pages" folder  and screen objects in the "Screens" folder. Here we define all the elements and methods needed concerning a specific page or screen. An example of the elements and actions on these elements defined in the login page of B-Tube is shown here:

Note that the class "LoginPage" is a child of BasePage and therefore inherits it's attributes and properties. The page should then be initialized using the DriverBuilder as following:

 
7. **Write test scripts**<br>
In the "Tests" folder, create a test class with a desired name. For testing the login functionalities, we created a suite called "TestLogin" for B-Tube. This is a class containing all scripts used in the login test suite. An example of test script where an existing user is logged into his B-Tube account is the following:
 

Note how all pages necessary for this specific test case are initialized using the builder. In this case it is "Navigation" and "LoginPage". After the pages are initialized, we can call upon all elements and methods we defined for this specific page. In this case we click on the "SignInButton" and execute the "Login" method.
 

 
8. **Run your script and have fun!**<br>
The scripts can be run from the Test Explorer
Optionally the scripts can be run by right-clicking on the method name
 
