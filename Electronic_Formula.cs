using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Formula_Library
{
    public class Electronic_Formula
    {
        //솔레노이드에 저장되는 에너지
        public double Solenoid_Energy(double Inductance, double Current)
        {
            double S_Energy = Inductance * Math.Pow(Current, 2) * 0.5;

            return S_Energy;
        }

        //운동에너지 구하기
        public double Kinetic_Velocity_Energy(double Projectile_Mass, double Velocity)
        {
            double Kinetic_Energy = Projectile_Mass * Math.Pow(Velocity, 2) * 0.5;

            return Kinetic_Energy;
        }

        //운동에너지로 속도 구하기
        public double Kinetic_Energy_Velocity(double Projectile_Mass, double Kinetic_Energy)
        {
            double Velocity = Math.Sqrt(Kinetic_Energy / Projectile_Mass * 2.0);

            return Velocity;
        }

        //솔레노이드 에너지로 속도구하기
        public double Solenoid_Velocity(double Projectile_Mass, double Solenoid_Inductance, double Solenoid_Current)
        {
            double S_Energy = Solenoid_Energy(Solenoid_Inductance, Solenoid_Current);

            double Velocity = Kinetic_Energy_Velocity(Projectile_Mass, S_Energy);

            return Velocity;
        }
    }
}
