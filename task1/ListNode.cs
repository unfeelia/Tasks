public sealed class ListNode<T>
    {
        public T value;

        public ListNode<T> next;

        public ListNode(T value)
		{
			this.value = value;
		}
        public void Insert(T newValue)
        {
            var last = this;
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = new ListNode<T>(newValue);
        }
    }