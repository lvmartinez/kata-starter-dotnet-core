using System;
using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_feeding_the_monkey
    {
        static Monkey _systemUnderTest;
        
        Establish context = () => 
            _systemUnderTest = new Monkey();

        Because of = () => 
            _systemUnderTest.Eat("banana");

        It should_have_the_food_in_its_belly = () =>
            _systemUnderTest.Belly.Should().Contain("banana");
    }

    public class when_user_input_is_empty
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add(); };

        It should_return_zero = () => { _result.Should().Be(0); };
        
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_one_number
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add(number: "3"); };

        It should_return_same_number = () => { _result.Should().Be( expected: 3); };
        
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_adding_two_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,3"); };

        It should_return_the_sum_of_both = () => { _result.Should().Be(4); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    public class when_adding_unkown_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,3,2"); };

        It should_return_the_sum_of_all = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    public class when_using_newline_delimiter
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1\n2,3"); };

        It should_return_the_sum_of_all = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    public class when_using_custom_delimiter
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("//;\n1;2"); };

        It should_return_the_sum_of_all = () => { _result.Should().Be(3); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    public class when_adding_negative_number
    {
        static Exception Exception;
        
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
            
        };
        
        Because of = () => { Exception = Catch.Exception(() => _result = _systemUnderTest.Add("-6")); };
        // _result = _systemUnderTest.Add("-6");
        
        It should_fail = () =>
            Exception.Should().Be(Exception);
        
        It should_have_a_specific_reason = () =>
            Exception.Message.Should().Contain("negatives");

        static Calculator _systemUnderTest;
        static int  _result;
    }
    
    public class when_adding_multiple_negative_number
    {
        static Exception Exception;
        
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
            
        };
        
        Because of = () => { Exception = Catch.Exception(() => _result = _systemUnderTest.Add("-6,8,-3")); };
        // _result = _systemUnderTest.Add("-6");
        
        It should_fail = () =>
            Exception.Should().Be(Exception);
        
        It should_have_a_specific_reason = () =>
            Exception.Message.Should().Contain("negatives");
        
       // It should_return_the_sum_of_all = () => { _result.Should().Be(8); };

        static Calculator _systemUnderTest;
        static int  _result;
    }
    
    public class when_maxnumber_thousand
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("\n2,1001"); };

        It should_return_the_sum_of_all = () => { _result.Should().Be(2); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    public class when_using_custom_multicharacter_delimiter
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("//[ ]\n1 2 3"); };

        It should_return_the_sum_of_all = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    public class when_using_multi_custom_multicharacter_delimiter
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("//[ ][%]\n1 2%3"); };

        It should_return_the_sum_of_all = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    }
}