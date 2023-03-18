using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Growlithe : Pokemon
	{
		public override string Name => "Growlithe";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Justified() };
		public override Stats BaseStats => new Stats(55, 70, 45, 70, 50, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Ember(), new Leer() },
			[4] = new List<Move>() { new Howl() },
			[8] = new List<Move>() { new Bite() },
			[12] = new List<Move>() { new Flamewheel() },
			[16] = new List<Move>() { new Helpinghand() },
			[20] = new List<Move>() { new Agility() },
			[24] = new List<Move>() { new Firefang() },
			[28] = new List<Move>() { new Retaliate() },
			[32] = new List<Move>() { new Crunch() },
			[36] = new List<Move>() { new Takedown() },
			[40] = new List<Move>() { new Flamethrower() },
			[44] = new List<Move>() { new Roar() },
			[48] = new List<Move>() { new Playrough() },
			[52] = new List<Move>() { new Reversal() },
			[56] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Attract(), new Bodyslam(), new Closecombat(), new Crunch(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firespin(), new Flamethrower(), new Flareblitz(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Outrage(), new Overheat(), new Playrough(), new Protect(), new Psychicfangs(), new Rest(), new Retaliate(), new Reversal(), new Roar(), new Rocksmash(), new Round(), new Safeguard(), new Sleeptalk(), new Snarl(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Wildcharge(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Bodyslam(), new Burnup(), new Closecombat(), new Covet(), new Crunch(), new Doubleedge(), new Doublekick(), new Firespin(), new Flareblitz(), new Heatwave(), new Howl(), new Morningsun(), new Thrash() };
		public override int Weight => 190;
		public override int ExpYield => 70;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}