#include<stdio.h>
#include<stdlib.h>

int main()
{
	int N = 0;
	scanf_s("%d", &N);
	int * numbers = (int *)malloc(sizeof(int)*N);
	int i = 0;
	while (i < N)
	{
		scanf_s("%d", numbers + i);
		i++;
	}

	long long sum = 0;
	if (N == 1)
	{
		printf("%d\n", numbers[0]);
	}
	else
	{

		while (N > 1)
		{
			int min1 = 0, min2 = 1;
			if (numbers[min1] > numbers[min2])
			{
				min1 = 1;
				min2 = 0;
			}

			for (int j = 2; j < N; j++)
			{
				int n = numbers[j];
				if (n < numbers[min1])
				{
					min2 = min1;
					min1 = n;
				}
				else if (n < numbers[min2])
				{
					min2 = n;
				}
			}

			int L = numbers[min1] + numbers[min2];
			sum += L;

			if (min1 == N - 1)
			{
				min1 = min2;
				min2 = N - 1;
			}
			numbers[min1] = L;
			numbers[min2] = numbers[N - 1];
			N--;
		}
		printf("%d\n", sum);
	}

	free(numbers);
	return 0;
}