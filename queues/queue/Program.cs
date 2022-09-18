// See https://aka.ms/new-console-template for more information

try
{
    CustomBasicQueue<int> st = new CustomBasicQueue<int>(3);

    st.Enqueue(22);
    st.Show();
    st.Enqueue(33);
    st.Enqueue(43);
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



