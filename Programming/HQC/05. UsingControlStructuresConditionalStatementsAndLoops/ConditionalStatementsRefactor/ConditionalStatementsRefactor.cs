Potato potato;
//... 
if (potato != null)
{
   if(potato.IsFresh && potato.HasBeenPeeled)
   {
        Cook(potato);
   }
}

//------------------------------------------

bool xIsInRange = MIN_X <= x && x =< MAX_X;
bool yIsInRange = MIN_Y <= y && y =< MAX_Y;

if (IsVisitableCell && xIsInRange && yIsInRange)
{
   VisitCell();
}