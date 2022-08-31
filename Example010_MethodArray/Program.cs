int[] array = {12,31,17,33,15,35,44,11};

int n = array.Length;
int find = 33;

int index = 0;

while (index < n ){
    if (array[index]== find){
        Console.WriteLine(index);
    }
    index++;
}
