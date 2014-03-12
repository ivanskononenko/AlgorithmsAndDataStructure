/**
 * Created by ivko on 3/12/14.
 */
public class PeopleComparable implements Comparable<PeopleComparable> {

    public String name;
    public  int age;
    public  int salary;

    @Override
    public int compareTo(PeopleComparable o) {
        if (this.age > o.age && this.salary > o.salary)
            return  1;
        else if (this.age < o.age && this.salary < o.salary)
            return  -1;
        return 0;
    }
}
