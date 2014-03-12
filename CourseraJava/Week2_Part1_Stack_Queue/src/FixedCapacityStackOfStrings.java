/**
 * Created by ivko on 3/11/14.
 */
public class FixedCapacityStackOfStrings {
    private String[] s;
    private int N = 0;

    public FixedCapacityStackOfStrings(int capacity){
        s = new String[capacity];
    }

    public  void push(String item){
        s[N++] = item;
    }

    public  String  pop(){
        return s[--N];
    }

    public static void main(String[] args){
        FixedCapacityStackOfStrings stack = new FixedCapacityStackOfStrings(20);

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
