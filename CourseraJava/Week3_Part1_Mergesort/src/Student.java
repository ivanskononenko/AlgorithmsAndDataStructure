import java.util.Comparator;

/**
 * Created by ivko on 3/18/14.
 */
public class Student
{
    public static final Comparator<Student> BY_NAME = new ByName();
    public static final Comparator<Student> BY_SECTION = new BySection();
    public static final Comparator<Student> BY_AGE = new ByAge();

    private final String name;
    private final int section;
    private final int age;

    public Student(String name, int section, int age) {
        this.name = name;
        this.section = section;
        this.age = age;
    }

    private static class ByName implements Comparator<Student>{
        public int compare(Student v, Student w){
            return v.name.compareTo(w.name);
        }
    }

    private static class BySection implements Comparator<Student>{
        public int compare(Student v, Student w){
            return v.section - w.section;
        }
    }

    private  static  class ByAge implements Comparator<Student>{

        @Override
        public int compare(Student o1, Student o2) {
            return  o1.age - o2.age;
        }
    }



    public  static  void  main(String[] args){
        //Integer[] arrForSort = {3,8,2,1,5,4,6,7,9};

        Student ivanS = new Student("Ivan", 2, 27);
        Student romanS = new Student("Roman", 3, 29);
        Student mykolaS = new Student("Mykola", 1, 26);
        Student olegS = new Student("Oleg", 2, 27);

        Student[] students = {ivanS,romanS,mykolaS,olegS};


        Insertion_ComparatorSort.sort(students, Student.BY_AGE);

        for (Student s : students)
            System.out.print(" Name: " + s.name + " Age: " + s.age);
    }
}