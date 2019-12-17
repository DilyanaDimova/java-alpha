package OOP.OOPTelerikAcademyAlphaProject.HospitalManagementSystem;

public class Doctor extends Staff{

    private String specialization;

    public Doctor() {
    }

    public Doctor(long id, String firstName, String lastName, String gender, String email,
                  int yearsOfExperience, String description, double salary, String specialization) {
        super(id, firstName, lastName, gender, email, yearsOfExperience, description, salary);
        this.specialization = specialization;
    }

    private void setSpecialization(String specialization){
        this.specialization = specialization;
    }

    public String getSpecialization(){
        return this.specialization;
    }
}
