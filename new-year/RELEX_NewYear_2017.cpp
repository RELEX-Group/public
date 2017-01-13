#include <iomanip>
#include <iostream>

const char* message = "Happy New Year 2017\n";

template <typename T> class abstract_print
{
	public:
		abstract_print<T[2]> message_;
		unsigned int value_;
				
		abstract_print(const char* message = ::message, unsigned int value = 16) :message_(message,value>>1), value_(value)
		{  
			message_ = abstract_print<T[2]>(message + (*this >> 1), value >> 1);
			if (*this == 16)
				std::cout << std::setw(3) << std::setfill('0') << (*this + 1);
		}
		
		operator int() const { return value_; };
};

template <> class abstract_print<char[2][2][2][2]>
{
	public:
		abstract_print(const char* message = ::message, unsigned int value = 16)
		{
			std::cout << *message;
		}
};

typedef abstract_print<char> print;
 
int main(int argc, char* argv[])
{
	print message;
	return 0;
}
