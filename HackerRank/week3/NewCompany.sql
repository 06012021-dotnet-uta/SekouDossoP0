-- New Company
select company_code, founder,
(select count(distinct lead_manager_code) from Lead_Manager where Company.company_code=Lead_Manager.company_code),
(select count(distinct senior_manager_code) from Senior_Manager where Company.company_code=Senior_Manager.company_code),
(select count(distinct manager_code) from Manager where Company.company_code=Manager.company_code),
(select count(distinct employee_code) from Employee where Company.company_code=Employee.company_code)
from Company 
order by company_code;

select Company.company_code, Company.founder,
    count(distinct Lead_Manager.lead_manager_code),
    count(distinct Senior_Manager.senior_manager_code),
    count(distinct Manager.manager_code),
    count(distinct Employee.employee_code)
from Company
join Lead_Manager
    on Lead_Manager.company_code = Company.company_code
join Senior_Manager
    on Senior_Manager.company_code = Company.company_code
join Manager
    on Manager.company_code = Company.company_code
join Employee
    on Employee.company_code = Company.company_code

group by Company.company_code , Company.founder
order by Company.company_code asc;
-- ***************
select Company.company_code, Company.founder,
    count(distinct Lead_Manager.lead_manager_code),
    count(distinct Senior_Manager.senior_manager_code),
    count(distinct Manager.manager_code),
    count(distinct Employee.employee_code)
   
from Company, Lead_Manager, Senior_Manager, Manager, Employee

where Lead_Manager.company_code = Company.company_code
    and Senior_Manager.company_code = Company.company_code
    and Manager.company_code = Company.company_code
    and Employee.company_code = Company.company_code

group by Company.company_code , Company.founder
order by Company.company_code asc;