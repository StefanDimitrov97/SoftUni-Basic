#include <iostream>
using namespace std;

void push_q(int n);
int pop_q(int &n);

void push_s(int m);
int pop_s(int &m);

struct elem_q
{
	int key; elem_q *next;
} *first = NULL, *last = NULL;

struct elem_s
{
	int key; elem_s *next;
} *start = NULL;

void Transform_QS(int x)
{
	cout << "Danni ot opashkata: ";
	while (pop_q(x))
	{
		push_s(x);
		cout << x << "  ";
	}
	cout << endl;

	cout << "Danni ot steka: ";
	while (pop_s(x))
	{
		cout << x << "  ";
	}
	cout << endl;
}

void main()
{
	int num;
	cout << endl << "Vavedete chisla, proizvolen simvol za krai: " << endl;
	while (cin >> num)
		push_q(num);
	cout << endl;

	Transform_QS(num);

	system("pause");
}

void push_q(int n)
{
	elem_q *p = last;
	last = new elem_q;
	last->key = n;
	last->next = NULL;
	if (p != NULL) p->next = last;
	if (first == NULL)
	{
		first = last;
	}
}

int pop_q(int &n)
{
	if (first)
	{
		n = first->key;
		elem_q *p = first;
		first = first->next;
		delete p;
		return 1;
	}
	else
		return 0;
}

void push_s(int m)
{
	elem_s *p = start;
	start = new elem_s;
	start->key = m;
	start->next = p;
}

int pop_s(int &m)
{
	if (start)
	{
		m = start->key;
		elem_s *p = start;
		start = start->next;
		delete p;
		return 1;
	}
	else
		return 0;
}