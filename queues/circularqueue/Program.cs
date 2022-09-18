// See https://aka.ms/new-console-template for more information

try
{
    CustomCircularQueue<int> st = new CustomCircularQueue<int>(3);

    st.Enqueue(22);
    st.Show();
    st.Enqueue(33);
    st.DeQueue();
    st.Enqueue(43);
    st.DeQueue();
    st.DeQueue();
    st.DeQueue();
    Console.WriteLine(st.GetSize());
    // st.Show();
    // st.DeQueue();
    // st.Show();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();




