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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Justified() };
		public override Stats BaseStats => new Stats(55, 70, 45, 70, 50, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Ember(), new Moves.Leer() },
			[4] = new List<Move>() { new Moves.Howl() },
			[8] = new List<Move>() { new Moves.Bite() },
			[12] = new List<Move>() { new Moves.Flamewheel() },
			[16] = new List<Move>() { new Moves.Helpinghand() },
			[20] = new List<Move>() { new Moves.Agility() },
			[24] = new List<Move>() { new Moves.Firefang() },
			[28] = new List<Move>() { new Moves.Retaliate() },
			[32] = new List<Move>() { new Moves.Crunch() },
			[36] = new List<Move>() { new Moves.Takedown() },
			[40] = new List<Move>() { new Moves.Flamethrower() },
			[44] = new List<Move>() { new Moves.Roar() },
			[48] = new List<Move>() { new Moves.Playrough() },
			[52] = new List<Move>() { new Moves.Reversal() },
			[56] = new List<Move>() { new Moves.Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Wildcharge(), new Moves.Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Burnup(), new Moves.Closecombat(), new Moves.Covet(), new Moves.Crunch(), new Moves.Doubleedge(), new Moves.Doublekick(), new Moves.Firespin(), new Moves.Flareblitz(), new Moves.Heatwave(), new Moves.Howl(), new Moves.Morningsun(), new Moves.Thrash() };
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