<Query Kind="Expression" />

/**********************************************
Exercise: Defining variables #1
Create public variables called firstName, lastName, and age.

Assign the variables your personal information.
***********************************************/


//Initial solution

using System;

namespace Phase0_Exercise1_Defining_Variables
{
  public class Exercise1VariableNames
    {
      String FirstName "Max";
      String LastName "Lott";
      int Age "20";
    }
}


// Refactored solution
using System;

namespace Phase0_Exercise1_Defining_Variables
{
  public class Exercise1VariableNames
    {
      public String FirstName = "Max";
      public String LastName = "Lott";
      public int Age = 20;
  	}
}
