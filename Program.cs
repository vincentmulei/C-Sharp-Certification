using part1;
using part2;
using part3;
using part4;
using working_with_files;
using enumstructrecordtypes;
using NullSafety;

var myFirstCode = new MyFirstCode();
//myFirstCode.HelloWorld();


var literals = new Literals();

//literals.StringLiterals();
//literals.IntegerLiterals();
//literals.FloatingPointLiterals();
//literals.BooleanLiterals();
//literals.ImplicitlyTypedLocalVariables();

var stringFormatting = new StringFormatting();

//stringFormatting.CharacterEscapes();
//stringFormatting.VerbatimStringLiterals();

var numberOperations = new NumberOperations();

//numberOperations.Addition();
//numberOperations.MathOperations();
//numberOperations.DivisionByDecimalLiteral();
//numberOperations.CastIntegerDivision();
//numberOperations.incrementOperatorBeforeAndAfterTheValue();
//numberOperations.Challenge();


var methodCall = new MethodCall();

//methodCall.GetLargerNumber();

var arrays = new Arrays();

//arrays.WorkingWithArrays();
//arrays.ArrayInitialization();
//arrays.Foreach();
//arrays.Challenge();

var branching = new Branching();
//branching.SwitchMethod();
//branching.ForLoop();
//branching.FizzBuzz();

var dataTypes = new DataTypes();

//dataTypes.SignedIntegralTypes();
//dataTypes.UnsignedIntegralTypes();
//dataTypes.SignedFloatingPointTypes();
//dataTypes.ReferenceTypeVariable();
//dataTypes.TypeCasting();
//dataTypes.ArrayHelperMethods();
//dataTypes.StringFormatting();

var file = new FileOperations();

//file.FileProperties();

var enumExample = new WorkwithEnum();

//enumExample.DisplayEnumValues();
//enumExample.ValidateEnumValue(3);
//enumExample.ValidateEnumValue(10);
//enumExample.IsWeekend(6);
//enumExample.IsWeekend(1);
//enumExample.updateOrderStatus();

// var rectangle = new Rectangle(5, 10);
// Console.WriteLine($"Area of the rectangle: {rectangle.Area}");

// var point1 = new Point(3, 4);
// var point2 = new Point(7, 1);
// Console.WriteLine($"Distance between the points: {point1.DistanceTo(point2)}");





var nullSafety = new NullSafetyImplementation();
nullSafety.Run();