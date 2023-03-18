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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Dancer() };
		public override Stats BaseStats => new Stats(75, 70, 70, 98, 70, 93);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Pound() },
			[4] = new List<Move>() { new Moves.Growl() },
			[6] = new List<Move>() { new Moves.Peck() },
			[10] = new List<Move>() { new Moves.Helpinghand() },
			[13] = new List<Move>() { new Moves.Aircutter() },
			[16] = new List<Move>() { new Moves.Batonpass() },
			[20] = new List<Move>() { new Moves.Featherdance() },
			[23] = new List<Move>() { new Moves.Doubleslap() },
			[26] = new List<Move>() { new Moves.Teeterdance() },
			[30] = new List<Move>() { new Moves.Roost() },
			[33] = new List<Move>() { new Moves.Captivate() },
			[36] = new List<Move>() { new Moves.Airslash() },
			[40] = new List<Move>() { new Moves.Revelationdance() },
			[43] = new List<Move>() { new Moves.Mirrormove() },
			[46] = new List<Move>() { new Moves.Agility() },
			[50] = new List<Move>() { new Moves.Hurricane() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Covet(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Embargo(), new Moves.Facade(), new Moves.Fly(), new Moves.Frustration(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icywind(), new Moves.Protect(), new Moves.Quash(), new Moves.Rest(), new Moves.Return(), new Moves.Roleplay(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Tailwind(), new Moves.Taunt(), new Moves.Toxic(), new Moves.Uturn(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Captivate(), new Moves.Pluck(), new Moves.Safeguard(), new Moves.Tailwind() };
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