package OOP.OOPTelerikAcademyAlphaProject.HospitalManagementSystem;

public class Nurse extends Staff {

    private int departmentId;

    public Nurse(){

    }

    public Nurse(long id, String firstName, String lastName, String gender, String email,
                 int yearsOfExperience, String description, double salary, int departmentId) {
        super(id, firstName, lastName, gender, email, yearsOfExperience, description, salary);
        this.departmentId = departmentId;
    }

    private void setDepartmentId(int departmentId){
        this.departmentId = departmentId;
    }

    public int getDepartmentId(){
        return this.departmentId;
    }
}
