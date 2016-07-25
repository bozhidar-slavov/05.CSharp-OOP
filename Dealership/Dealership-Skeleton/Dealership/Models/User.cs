namespace Dealership.Models
{
    using Common;
    using Common.Enums;
    using Contracts;

    using System;
    using System.Collections.Generic;
    using System.Text;

    public class User : IUser
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private Role role;
        private IList<IVehicle> vehicles;

        public User(string username, string firstName, string lastName, string password, string role)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = (Role)Enum.Parse(typeof(Role), role);
            this.Vehicles = new List<IVehicle>();
        }

        public string FirstName
        {
            get { return this.firstName; }

            protected set
            {
                Validator.ValidateNull(value, "Firstname cannot be null!");
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Firstname", Constants.MinNameLength, Constants.MaxNameLength));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            protected set
            {
                Validator.ValidateNull(value, "Lastname cannot be null!");
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Lastname", Constants.MinNameLength, Constants.MaxNameLength));

                this.lastName = value;
            }
        }

        public string Password
        {
            get { return this.password; }

            protected set
            {
                Validator.ValidateNull(value, "Password cannot be null!");
                Validator.ValidateIntRange(value.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Password", Constants.MinPasswordLength, Constants.MaxPasswordLength));
                Validator.ValidateSymbols(value, Constants.PasswordPattern,
                    string.Format(Constants.InvalidSymbols, "Password"));

                this.password = value;
            }
        }

        public Role Role
        {
            get { return this.role; }

            protected set
            {
                Validator.ValidateNull(value, "Role cannot be null!");

                this.role = value;
            }
        }

        public string Username
        {
            get { return this.username; }

            protected set
            {
                Validator.ValidateNull(value, "Username cannot be null!");
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Username", Constants.MinNameLength, Constants.MaxNameLength));
                Validator.ValidateSymbols(value, Constants.UsernamePattern,
                    string.Format(Constants.InvalidSymbols, "Username"));

                this.username = value;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get { return this.vehicles; }

            protected set
            {
                Validator.ValidateNull(value, "Vehicles cannot be null!");

                this.vehicles = value;
            }
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            vehicleToAddComment.Comments.Add(commentToAdd); 
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (commentToRemove.Author == this.Username)
            {
                vehicleToRemoveComment.Comments.Remove(commentToRemove);
            }
            else
            {
                throw new ArgumentException(Constants.YouAreNotTheAuthor);
            }
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if (this.Role == Role.Admin)
            {
                throw new ArgumentException(Constants.AdminCannotAddVehicles);
            }
            else if (this.Role == Role.Normal && this.Vehicles.Count == Constants.MaxVehiclesToAdd)
            {
                throw new ArgumentException(string.Format(Constants.NotAnVipUserVehiclesAdd, Constants.MaxVehiclesToAdd));
            }
            else
            {
                this.Vehicles.Add(vehicle);
            }
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            this.Vehicles.Remove(vehicle);
        }

        public string PrintVehicles()
        {
            var result = new StringBuilder();
            int i = 1;

            result.AppendLine(string.Format("--USER {0}--", this.Username));
            if (this.Vehicles.Count == 0)
            {
                result.AppendLine("--NO VEHICLES--");
            }
            else
            {
                foreach (var vehicle in this.Vehicles)
                {
                    result.AppendLine(i + ". " + vehicle.ToString());
                    i++;
                    if (vehicle.Comments.Count > 0)
                    {
                        result.AppendLine("    --COMMENTS--");
                        foreach (var comment in vehicle.Comments)
                        {
                            result.AppendLine("    ----------");
                            result.AppendLine(string.Format("    {0}", comment.Content));
                            result.AppendLine(string.Format("      User: {0}", comment.Author));
                            result.AppendLine("    ----------");
                        }

                        result.AppendLine("    --COMMENTS--");
                    }
                    else
                    {
                        result.AppendLine("    --NO COMMENTS--");
                    }
                }
            }

            return result.ToString().Trim();
        }

        public override string ToString()
        {
            return string.Format("Username: {0}, FullName: {1} {2}, Role: {3}", this.Username, this.FirstName, this.LastName, this.Role);
        }
    }
}
