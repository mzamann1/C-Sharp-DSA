// See https://aka.ms/new-console-template for more information

try
{
    CustomStack<int> st = new CustomStack<int>(5);

    st.Show();
    st.Push(100);
    st.Push(101);
    st.Push(102);
    st.Show();
    st.Pop();
    st.Show();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();



