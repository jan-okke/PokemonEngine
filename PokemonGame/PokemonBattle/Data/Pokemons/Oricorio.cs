using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Oricorio : Pokemon
	{
		public override string Name => "Oricorio";
		public override List<Ability> AvailableAbilities => new() {new Dancer() };
		public override Stats BaseStats => new Stats(75, 70, 70, 93, 98, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound() },
			[4] = new List<Move>() { new Growl() },
			[6] = new List<Move>() { new Peck() },
			[10] = new List<Move>() { new Helpinghand() },
			[13] = new List<Move>() { new Aircutter() },
			[16] = new List<Move>() { new Batonpass() },
			[20] = new List<Move>() { new Featherdance() },
			[23] = new List<Move>() { new Doubleslap() },
			[26] = new List<Move>() { new Teeterdance() },
			[30] = new List<Move>() { new Roost() },
			[33] = new List<Move>() { new Captivate() },
			[36] = new List<Move>() { new Airslash() },
			[40] = new List<Move>() { new Revelationdance() },
			[43] = new List<Move>() { new Mirrormove() },
			[46] = new List<Move>() { new Agility() },
			[50] = new List<Move>() { new Hurricane() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Calmmind(), new Confide(), new Covet(), new Defog(), new Doubleteam(), new Embargo(), new Facade(), new Fly(), new Frustration(), new Helpinghand(), new Hiddenpower(), new Icywind(), new Protect(), new Quash(), new Rest(), new Return(), new Roleplay(), new Roost(), new Round(), new Safeguard(), new Sandstorm(), new Skyattack(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Swagger(), new Swordsdance(), new Tailwind(), new Taunt(), new Toxic(), new Uturn(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Captivate(), new Pluck(), new Safeguard(), new Tailwind() };
		public override int Weight => 34;
		public override int ExpYield => 167;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}