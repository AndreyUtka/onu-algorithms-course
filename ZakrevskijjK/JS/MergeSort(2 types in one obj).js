var insertionSort = function ()
{
   function insertionSortBasePrivate(data)
   {
       for (var i = 1; i < data.length; i++)
       {
           var over = data[i];
           for (var j = i - 1; j >= 0 && data[j] > over; j--)
           {
               data[j + 1] = data[j];
           }
           data[j + 1] = over;
       }
   }

   function InsertionSortBaseII(mas, token)
   {
       for (var i = 1; i < mas.length; i++)
       {
           var x = mas[i];
           var j = i - 1;
           while (j >= 0 && (token ? (mas[j] < x) : (mas[j] > x))) {
               mas[j + 1] = mas[j];
               j--;
           }
           mas[j + 1] = x;
       }
   }

   return{
       insertionSortBase: insertionSortBasePrivate,
       insertionSortBaseTrinary: InsertionSortBaseII
   }
};

mas=[12,12,45,0,13,0];
var i=new insertionSort();
i.insertionSortBase(mas);

for (var j = 0; j <mas.length; j++)
{
   console.log(mas[j]);
}