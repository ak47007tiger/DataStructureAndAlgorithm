namespace DataStructure
{

  public class SinglyLinkedListTest : BaseSolution
  {

    public void SimpleTest()
    {
      var list = new SinglyLinkedList();
      println(list.IsEmpty());

      list.Add(new ListNode(1));

      println(list.IsEmpty());

      list.Add(new ListNode(2));
      println(list.Size());

      println(list.Get(1).val);

      list.Remove(list.Get(0));
      println(list.Size());

      list.Add(new ListNode(3));
      list.Add(new ListNode(4), 1);

      println(list.Get(list.Size() - 2).val);

      list.Clear();
      println(list.IsEmpty());
    }

  }

}
