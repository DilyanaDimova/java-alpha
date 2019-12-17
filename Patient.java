package OOP.OOPTelerikAcademyAlphaProject.HospitalManagementSystem;

public class Patient extends User {

    private boolean insured;

    public Patient() {

    }

    public Patient(long id, String firstName, String lastName, String gender, String email, Boolean insured) {
        super(id, firstName, lastName, gender, email);
        this.insured = insured;
    }

    private void setInsured(boolean insured) {
        this.insured = insured;
    }

    public boolean isInsured() {
        return this.insured;
    }
}
