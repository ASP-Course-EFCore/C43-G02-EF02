using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{

    ///1- By Convention
    ///class Employee
    ///{
    ///    public int Id { get; set; } // Public Numeric Property Named as "Id" or "ClassName+Id" => Will Be Mapped As Primary Key column with identity [1,1] on the column.
    ///    public required string FName { get; set; }// Reference Types "string" property [Not Nullable] => Mapped as column of type "nVarchar(max)" with constraint not allow null[Required].
    ///    public string? LName { get; set; }// Nullable Reference Types "string?" property => Mapped as column of type "nVarchar(max)" with constraint allow null [optional].
    ///    public double Salary { get; set; }// Non-Nullable ValueType "double" property => Mapped as column of type "float" with constraint not allow null [Required]
    ///    public int? Age { get; set; }// Nullable ValueType "int?" property => Mapped as column of type "int" with constraint allow null [optional]
    ///}

    //2- By Data Annotations [Set Of Attributes]

    //[Table("hamada",Schema = "HR")]//If you need this table to mapped with other name not "Employees" like in "DbContext" Class and in schema "HR" not "dbo" - if not found schema "HR" it will create it.
    class Employee
    {

        //[new KeyAttribute()] // Mapped Property "Code" As "Pk" Column In DB => New Behavior عشان اديله KeyAttributeدي معناها ان انا مسكت ال انتيجر كود وروحت غلفته جوا اوبجكت نوعه 
        [Key]// Syntax Sugar for [new KeyAttribute()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity/*Enum*/)]// To make this column "Code" use identity(1,1).
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]// To make this column "Code" Not use identity(1,1) - Default - It will be useful if the property named "Id" and use convention way but i don't need to use the identity.
        public int Code { get; set; }//By Convention => It Will Mapped As Normal Column Not PK Column.

        [Column(TypeName = "varchar")]//Map property "Name" as column of type varchar(1) not nVarchar(max)
        [StringLength(50, MinimumLength = 10)]//Map property "Name" as column of type varchar(50) not nVarchar(max) -
                                              //there is no validation in sql(database) called "MinimumLength" so this validation will not mapped in DB -
                                              //it's just validation For Application[Code] - Mean if make object from class Employee and set the name property to "name < 10" => throw Exception.
                                              //Employee emp = new Employee(){Name = "Ali"}; => Exception.
        //[MaxLength(50)]// Mapped => Say That the values that will be added in the column name will be of MaxLength 50.
        //[MinLength(50)]// Not-Mapped => Just Validation For Application
        [Length(10, 50)]// Not-Mapped => Just Validation For Application
        //[Required]//Column Name will not Allow Null => But you say in the App that it's of type "string?" which allow null - so make Application Like DB - And you don't need to use this Attribute - because if you need this column Required make it of type "string" and if you need it optional allow null make it of type "string?"
        public string? Name { get; set; }//By Convention => it will mapped as column "Name" of type nVarchar(max).

        [Column(TypeName = "decimal(12,2)")]// //Map property "Salary" as column of type decimal(12,2) not float.
        [DataType(DataType.Currency)]//[Not-Mapped] Just For Display - To Display values of this property in Currency$ Format/view.
        public double Salary { get; set; }//By Convention => it will mapped as column "Salary" of type float.

        [Range(15, 35)]//[Not-Mapped] Just Application Validation To say in code that this property Age Will Be Set only by values between [18 - 35]
        [AllowedValues(20, 30, 40, 50)]//Just Application Validation To Say Tht this property Age will be set only to one of those values [20-30-40-50].
        [DeniedValues(25, 35)]//[Not-Mapped]Just Application Validation To Say Tht this property Age can't be set to one of those values [25-35].
        public int? Age { get; set; }

        [EmailAddress]//[Not-Mapped] Just Application Validation in code to say this property "Email" will be assigned with string value with Email Format only otherwise throw Exception
        [DataType(DataType.EmailAddress)]//[Not-Mapped] Just For Display - To Display values of this property in Email Address Format/view.
        public string? Email { get; set; }

        [DataType(DataType.Password)]//[Not-Mapped] Just For Display - To Display values of this property in Password *** Format/view.
        [RegularExpression("")]//[Not-Mapped] Just For Validation - To Say that this property "Password" will be assigned only to value with specific Pattern/Format
        public string? password { get; set; }

        [Phone(ErrorMessage = "Must be 11 digits!")]//[Not-Mapped] Just For Validation, To Say that this property will set to values of format PhoneNumber only - and this error message will be viewed in the HTML page of this class "Employee" when user enter invalid input.
        [DataType(DataType.PhoneNumber)]//[Not-Mapped] Just For Display - To Display values of this property in PhoneNumber Format/view.
        public string? PhoneNumber { get; set; }

        //Note => 
        //Those Data Annotations [Properties] that are work as Validations or Displays =>  Work only When You work on ASP.NET Core Application Not Console Application
        //Mean That like if you Assign To "Email" property value "Hamada" it will not throw Exception.
        //And if you try to view the Salary Value will be not viewed as Currency Format.
    }

}
