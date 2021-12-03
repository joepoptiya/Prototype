Feature: RoleAssignmentSecurity
	In order to provide control to ServiceRole owners on assigning their roles to teams
	As a ServiceRole Owner
	I want to specify if my ServiceRole cane be assigned to a team with my approval
	OR if my ServiceRole cane be assigned to a team with notificate sent to me
	OR if my ServiceRole cane be assigned to a team without any restrictions or notifications

@RoleAssignmentSecurity
Scenario: Service Role is created by the owner without any restrictions
	Given A ServiceRole is created by a Service owner
	And No approval is required by the owner
	And No notification is required
	When A user assignes the ServiceRole to a Team
	Then The ServiceRole is assigned to the Team
	And No approval is triggered
	And No notification is sent

@RoleAssignmentSecurity
Scenario: Assigning a ServiceRole to a Team and sending notification to owner	
	Given A ServiceRole is created by a Service owner
	And No approval is required by the owner
	And Check the "Send notification to owner" option
	When A user assignes the ServiceRole to a Team
	Then The ServiceRole is assigned to the Team
	And No approval is triggered
	And RoleAssignemnt Notification is sent to ServiceRole Owner

@RoleAssignmentSecurity
Scenario: Assigning a ServiceRole to a Team and approval by owner is required	
	Given A ServiceRole is created by a Service owner
	And Check the "Owner Approval is Required" option
	And No notification is required
	When A user assignes the ServiceRole to a Team
	Then The ServiceRole is assigned to the Team
	And Approval is triggered for RoleAssignment
	And Approval Notification is sent to the ServiceRole Owner
	And No notification is sent

@RoleAssignmentSecurity
Scenario: Assigning a ServiceRole to a Team and approval by owner is required and notification to owner is sent	
	Given A ServiceRole is created by a Service owner
	And Check the "Owner Approval is Required" option
	And Check the "Send notification to owner" option
	When A user assigns the ServiceRole to a Team
	Then The ServiceRole is assigned to the Team
	And RoleAssignemnt Notification is sent to ServiceRole Owner
	And Approval is triggered for RoleAssignment
	And Approval Notification is sent to the ServiceRole Owner
	And Request is approved by the Owner
	And Request is updated for completed and approved
	And Notification of approval is sent to the Requestor

@RoleAssignmentSecurity
Scenario: Assigning a ServiceRole to a Team and approval by owner is required and rejected
	Given A ServiceRole is created by a Service owner
	And Check the "Owner Approval is Required" option
	And No notification is required
	When A user assigns the ServiceRole to a Team
	Then The ServiceRole is assigned to the Team
	And No notification is sent
	And Approval is triggered for RoleAssignment
	And Approval Notification is sent to the ServiceRole Owner
	And Request is rejected by the Owner
	And Request is updated for completed and rejected
	And Notification of rejection is sent to the Requestor
