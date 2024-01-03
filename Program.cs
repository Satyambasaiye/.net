
using HRAPP;
using HRAPP.controllers;
using HRAPP.entities;
using HRAPP.Services;
using HRAPP.Views;

Console.WriteLine("-----------hrApp----------------");
IEmployeeService EmpService = new EmployeeService();
EmployeeControllers EmpController = new EmployeeControllers(EmpService);
List<Employee> list = EmpController.GetAll();
Iview view = new ListView(list);
view.render();

Employee emp = new Employee { id = 2, name = "himanshu", basicSalary = 3000, pf = 300, da = 400, tax = 400 };


