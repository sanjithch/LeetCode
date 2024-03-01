public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> mystack = new Stack<int>();
        int n = tokens.Length;

        for(int i=0;i<n;i++){
            int fir = 0;
            int sec = 0;
            if(tokens[i]=="+"){
                sec = mystack.Pop();
                fir = mystack.Pop();
                mystack.Push(fir+sec);
            }
            else if(tokens[i]=="*"){
                sec = mystack.Pop();
                fir = mystack.Pop();
                mystack.Push(fir*sec);
            }
            else if(tokens[i]=="/"){
                sec = mystack.Pop();
                fir = mystack.Pop();
                mystack.Push(fir/sec);
            }
            else if(tokens[i]=="-"){
                sec = mystack.Pop();
                fir = mystack.Pop();
                mystack.Push(fir-sec);
            }
            else{
                mystack.Push(int.Parse(tokens[i]));
            }
        }

        return mystack.Pop();
    }
}
