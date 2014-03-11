/**
 * Created by ivko on 3/11/14.
 */
public class ResizingArrayStackOfStrings {

    String[] s;
    int N =0;

    public ResizingArrayStackOfStrings(){
        s = new String[1];
    }

    public void push(String item){
        if (N == s.length)
            resize(2 * s.length);
        s[N++] = item;
    }

    public String pop()
    {
        String item = s[--N];
        s[N] = null;
        if (N > 0 && N == s.length/4) resize(s.length/2);
        return item;
    }

    private void resize(int capacity){
        String[] copy = new String[capacity];
        for (int i = 0; i < N; i++)
            copy[i] = s[i];
        s = copy;
    }

    public  static  void  main(String[] args){
        ResizingArrayStackOfStrings stack = new ResizingArrayStackOfStrings();

        String inputString = "to be or not to - be - - that - - - is";

        String[] strArr = inputString.split(" ");

        for(String str : strArr){
            if (str.equals("-"))
                System.out.print(" " + stack.pop());
            else
                stack.push(str);

    }
    }
}
