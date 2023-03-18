using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Chandelure : Pokemon
	{
		public override string Name => "Chandelure";
		public override List<Ability> AvailableAbilities => new() {new Flashfire(), new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Infiltrator() };
		public override Stats BaseStats => new Stats(60, 55, 90, 80, 145, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Confuseray(), new Hex(), new Willowisp(), new Firespin(), new Nightshade(), new Curse(), new Shadowball(), new Inferno(), new Imprison(), new Painsplit(), new Overheat(), new Memento(), new Astonish(), new Smog(), new Ember(), new Minimize() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Burningjealousy(), new Calmmind(), new Darkpulse(), new Endure(), new Energyball(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Gigaimpact(), new Heatwave(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Mysticalfire(), new Overheat(), new Payback(), new Poltergeist(), new Protect(), new Psychic(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Taunt(), new Thief(), new Trick(), new Trickroom(), new Willowisp() };
		public override int Weight => 343;
		public override int ExpYield => 260;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}