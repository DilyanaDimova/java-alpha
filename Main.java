package OOP.OOPTelerikAcademyAlphaProject.HospitalManagementSystem;

public class Main {
    public static void main(String[] args){

        User user1 = new User();
        System.out.println("***");

        User user2 = new User(1, "John", "Smith", "male", "john@gmail.com");
        System.out.println("***");

        Staff staff1 = new Staff();
        System.out.println("***");

        Staff staff2 = new Staff(2, "Maria", "Gonzales", "female", "maria@gmail.com", 2, "Cleaning staff", 156.50);
        System.out.println("***");

        Patient patient1 = new Patient();
        System.out.println("***");

        Patient patient2 = new Patient(3, "Patric", "Jackson", "male", "pathrik@gmail.com", false);
        System.out.println("***");

        Nurse nurse1 = new Nurse();
        System.out.println("***");

        Nurse nurse2 = new Nurse(4, "Sara", "Kennedy", "female", "sarra@gmail.com", 5, "Head of nurses", 280.45, 4);
        System.out.println("***");

        Doctor doctor1 = new Doctor();
        System.out.println("***");

        Doctor doctor2 = new Doctor(5, "Martin", "Luther", "male", "martin@gmail.com", 10, "ER", 1500.00, "Surgeon");
        System.out.println("***");



    }
}
