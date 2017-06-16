namespace DalService.Abstract
{
    public abstract class BaseVM<T> where T : class 
    {
        public T Entity { get; set; }
    }
}
