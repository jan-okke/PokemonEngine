using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tapulele : Pokemon
	{
		public override string Name => "Tapu Lele";
		public override List<Ability> AvailableAbilities => new() {new Psychicsurge() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(70, 85, 75, 130, 115, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Astonish(), new Confusion() },
			[5] = new List<Move>() { new Withdraw() },
			[10] = new List<Move>() { new Aromatherapy() },
			[15] = new List<Move>() { new Drainingkiss() },
			[20] = new List<Move>() { new Psybeam() },
			[25] = new List<Move>() { new Flatter() },
			[30] = new List<Move>() { new Aromaticmist() },
			[35] = new List<Move>() { new Sweetscent() },
			[40] = new List<Move>() { new Extrasensory() },
			[45] = new List<Move>() { new Psyshock() },
			[50] = new List<Move>() { new Meanlook() },
			[55] = new List<Move>() { new Naturesmadness() },
			[60] = new List<Move>() { new Moonblast() },
			[65] = new List<Move>() { new Tickle() },
			[70] = new List<Move>() { new Skillswap() },
			[75] = new List<Move>() { new Psychicterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Endure(), new Energyball(), new Facade(), new Fling(), new Focusblast(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Lightscreen(), new Magicroom(), new Playrough(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psychocut(), new Psyshock(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Speedswap(), new Storedpower(), new Substitute(), new Sunnyday(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Wonderroom() };
		public override int Weight => 186;
		public override int ExpYield => 285;
		public override int CatchRate => 3;
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