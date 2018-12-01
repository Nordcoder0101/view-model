using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using viewModel_fun.Models;

namespace viewModel_fun.Models
{
  public class Message
  {
    public string TheMessage {get;set;}
    // public Message(string Message)
    // {
    //   TheMessage = Message;
    // }
  }

  public class NumberArray
  {
    
    public int[] TheIntArray = new int[5];
    public NumberArray(int[] IntArray)
    {
      
      TheIntArray = IntArray;

    
    }
    
  }


  public class User
  {
    public string TheFirstName {get;set;}
    public string TheLastName {get;set;}
    
    public User(string FirstName, string LastName)
    {
      TheFirstName = FirstName;
      TheLastName = LastName;
    }
  }
}

public class AllTheUsers{
  public List<User> AllUsers = new List<User>();

  public AllTheUsers(List<User> UserList)
  {
    AllUsers = UserList;
  }
}

namespace viewModel_funController 
{
  public class viewModel_funController : Controller 
  {
    

    [HttpGet]
    [Route("")]
    public IActionResult Message()
    {
      Message TheMessage = new Message()
      {
        TheMessage = "This is the message I want to render!"
      };
      return View(TheMessage);
    }

    [HttpGet]
    [Route("intarray")]

    public IActionResult IntArray()
    {
      int[] MyNumArray = {1, 2, 3, 4, 5};
      NumberArray TheIntArray = new NumberArray(MyNumArray);
      
      return View(TheIntArray);
    }

    [HttpGet]
    [Route("user")]

    public IActionResult ShowUser()
    {
      User Greg = new User("Greg", "Nordeng");
      

      return View(Greg);
    }

    [HttpGet]
    [Route("allusers")]

    public IActionResult ShowAllUser()
    {
      User Greg = new User("Greg", "Nordeng");
      User Tom = new User("Tom", "Jones");
      User Fred = new User("Fred", "Med");

      List<User> UserList = new List<User>();
      UserList.Add(Greg);
      UserList.Add(Tom);
      UserList.Add(Fred);

      AllTheUsers AllUserList = new AllTheUsers(UserList);
      
      
      

      return View(AllUserList);
    }
  }
}