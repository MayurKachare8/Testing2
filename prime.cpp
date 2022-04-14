#include<iostream>
using namespace std;
int main(){
	int num, loop;
	int prime = 1;
	cout<<"Enter the number to check prime or not :   ";
	cin>>num;

	for(loop=2;loop<num; loop++);{
		if ((num / loop)==0)
			{
				prime=0;
				/* code */
			}	
	
	}
	if (prime==1)
			{
				cout<<num<<"  is the prime number  .";
				/* code */
			}
	else
			cout<<num<<"is not a prime number .";				

	return 0;

}