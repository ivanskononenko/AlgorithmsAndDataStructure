/**
 * Created by ivko on 3/11/14.
 */
public class StackOfStrings {

    private Node first = null;

    public  void push(String item){
        Node oldFirst = first;
        first = new Node();
        first.item = item;
        first.next = oldFirst;
    }

    public String pop(){
        String item = first.item;
        first = first.next;
        return  item;
    }

    public static void main(String[] args)
    {
        StackOfStrings stack = new StackOfStrings();

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
