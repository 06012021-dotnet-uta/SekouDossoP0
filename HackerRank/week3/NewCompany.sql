-- New Company
select company_code, founder,
(select count(distinct lead_manager_code) from Lead_Manager where Company.company_code=Lead_Manager.company_code),
(select count(distinct senior_manager_code) from Senior_Manager where Company.company_code=Senior_Manager.company_code),
(select count(distinct manager_code) from Manager where Company.company_code=Manager.company_code),
(select count(distinct employee_code) from Employee where Company.company_code=Employee.company_code)
from Company 
order by company_code;

