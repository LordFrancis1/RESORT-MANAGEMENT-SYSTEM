Module UC_Classes
    '
    '||START UP CLASSES
    '
    Public launch As Applauncher
    Public Intro As AppIntroduction
    Public Shut_Down As ShutDown
    Public Home_Page As HomePage
    Public log_in As LogIn
    Public Password_Reset As PasswordReset
    Public signup_display As New SignUpDisplay
    Public sign_up As SignUpForm
    Public Account_Recovery As AccountRecovery
    '
    '||MAIN CLASSES
    '
    Public Dashboard As DashBoard
    Public GuestReservation As DepartmentReservation
    Public RoomHouseKeeping As DepartmentHouseKeeping
    Public Print As PrintModule
    Public PrintType As PrintTypeQuery
    Public Messaging As MessageModule
    Public E_Mail As Mail
    Public s_m_s As SMS
    '
    '||Reservation Department
    '
    Public CheckIn As GuestCheckIn
    Public CheckInForm As GuestCheckinForm
    Public CheckInSearch As New GuestCheckInSearch
    Public CheckOut As GuestCheckOut
    Public DueIn As GuestDueIn
    Public GuestDueInSub As GuestDueInDialog
    Public Allocation As GuestAllocations
    Public HotelRooms As New GuestRooms
    Public RoomStatus As RoomStatusDialog
    Public Guest_Report As GuestReport
    Public GuestBoard As GuestDashboard
    'Booking
    Public RoomBooking As Booking
    Public RoomSelected As SelectedRoom
    '
    '||House Keeping Department
    '
    Public AddRooms As HouseKeeping_AddRooms
    Public HsKeeping_Status As HouseKeeping_RoomStatus

    '
    '||
    '

End Module
