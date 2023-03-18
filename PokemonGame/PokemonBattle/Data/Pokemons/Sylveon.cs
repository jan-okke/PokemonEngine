using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sylveon : Pokemon
	{
		public override string Name => "Sylveon";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pixilate() };
		public override Stats BaseStats => new Stats(95, 65, 65, 110, 130, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Disarmingvoice() },
			[1] = new List<Move>() { new Disarmingvoice(), new Covet(), new Bite(), new Copycat(), new Batonpass(), new Takedown(), new Charm(), new Doubleedge(), new Helpinghand(), new Tackle(), new Growl(), new Tailwhip() },
			[5] = new List<Move>() { new Sandattack() },
			[10] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Babydolleyes() },
			[20] = new List<Move>() { new Swift() },
			[25] = new List<Move>() { new Lightscreen() },
			[30] = new List<Move>() { new Drainingkiss() },
			[35] = new List<Move>() { new Mistyterrain() },
			[40] = new List<Move>() { new Skillswap() },
			[45] = new List<Move>() { new Psychup() },
			[50] = new List<Move>() { new Moonblast() },
			[55] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Bodyslam(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Dig(), new Drainingkiss(), new Endure(), new Facade(), new Faketears(), new Focusenergy(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Lightscreen(), new Magicalleaf(), new Mistyexplosion(), new Mistyterrain(), new Mysticalfire(), new Payday(), new Playrough(), new Protect(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Sunnyday(), new Swift(), new Weatherball(), new Workup() };
		public override int Weight => 235;
		public override int ExpYield => 184;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}