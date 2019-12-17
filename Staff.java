package OOP.OOPTelerikAcademyAlphaProject.HospitalManagementSystem;

public class Staff extends User {

    private int yearsOfExperience;
    private String description;
    private double salary;

    public Staff() {

    }

    public Staff(long id, String firstName, String lastName, String gender, String email, int yearsOfExperience, String description, double salary) {
        super(id, firstName, lastName, gender, email);
        this.yearsOfExperience = yearsOfExperience;
        this.description = description;
        this.salary = salary;
    }

    private void setYearsOfExperience(int yearsOfExperience){
        this.yearsOfExperience = yearsOfExperience;
    }

    private void setDescription(String description){
        this.description = description;
    }

    private void setSalary(double salary){
        this.salary = salary;
    }

    public int getYearsOfExperience(){
        return this.yearsOfExperience;
    }

    public String getDescription(){
        return this.description;
    }

    public double getSalary(){
        return this.salary;
    }

}
